// *********************************************************************
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License
// *********************************************************************
import React from 'react';
import PropTypes from 'prop-types';
import * as Helpers from '../../flowHelpers';
import * as Models from '../../flowModels';
import { TextField, Label, Dropdown } from 'office-ui-fabric-react';

export default class BlobSinkerSettings extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div style={rootStyle}>
                <div style={sectionStyle}>
                    <TextField
                        className="ms-font-m info-settings-textbox"
                        spellCheck={false}
                        label="Alias"
                        value={this.props.sinker.id}
                        onChange={(event, value) => this.props.onUpdateSinkerName(value)}
                        onGetErrorMessage={value => this.validateProperty(value)}
                    />
                </div>

                <div style={sinkTypeSection}>
                    <TextField
                        className="ms-font-m info-settings-textbox"
                        spellCheck={false}
                        label="Sink Type"
                        disabled={true}
                        value={this.props.sinkerDisplayName}
                    />
                </div>

                <div style={sectionStyle}>
                    <TextField
                        type="password"
                        className="ms-font-m"
                        spellCheck={false}
                        label="Connection String"
                        value={this.props.sinker.properties.connectionString}
                        onChange={(event, value) => this.props.onUpdateBlobConnection(value)}
                        autoAdjustHeight
                        resizable={false}
                    />
                </div>

                <div style={sectionStyle}>
                    <TextField
                        className="ms-font-m info-settings-textbox"
                        spellCheck={false}
                        label="Container Name"
                        value={this.props.sinker.properties.containerName}
                        onChange={(event, value) => this.props.onUpdateBlobContainerName(value)}
                        onGetErrorMessage={value => this.validateProperty(value)}
                    />
                </div>

                <div style={sectionStyle}>
                    <TextField
                        className="ms-font-m info-settings-textbox"
                        spellCheck={false}
                        label="Blob Prefix"
                        value={this.props.sinker.properties.blobPrefix}
                        onChange={(event, value) => this.props.onUpdateBlobPrefix(value)}
                    />
                </div>

                <div style={sectionStyle}>
                    <TextField
                        className="ms-font-m info-settings-textbox"
                        spellCheck={false}
                        label="Blob Partition Format"
                        placeholder="example: yyyy/MM/dd/HH"
                        value={this.props.sinker.properties.blobPartitionFormat}
                        onChange={(event, value) => this.props.onUpdateBlobPartitionFormat(value)}
                    />
                </div>

                {this.renderFormatTypeDropdown()}
                {this.renderCompressionTypeDropdown()}
            </div>
        );
    }

    renderFormatTypeDropdown() {
        const options = Models.sinkerFormatTypes.map(type => {
            return {
                key: type.key,
                text: type.name,
                disabled: type.disabled
            };
        });

        return (
            <div style={sectionStyle}>
                <Label className="ms-font-m info-settings-textbox">Format</Label>
                <Dropdown
                    className="ms-font-m info-settings-textbox"
                    options={options}
                    selectedKey={this.props.sinker.properties.format}
                    onChange={(event, selection) => this.props.onUpdateFormatType(selection.key)}
                />
            </div>
        );
    }

    renderCompressionTypeDropdown() {
        const options = Models.sinkerCompressionTypes.map(type => {
            return {
                key: type.key,
                text: type.name,
                disabled: type.disabled
            };
        });

        return (
            <div style={sectionStyle}>
                <Label className="ms-font-m info-settings-textbox">Compression</Label>
                <Dropdown
                    className="ms-font-m info-settings-textbox"
                    options={options}
                    selectedKey={this.props.sinker.properties.compressionType}
                    onChange={(event, selection) => this.props.onUpdateCompressionType(selection.key)}
                />
            </div>
        );
    }

    validateProperty(value) {
        if (value === '') return '';
        return !Helpers.isNumberAndStringOnly(value) ? 'Letters, numbers, and underscores only' : '';
    }
}

// Props
BlobSinkerSettings.propTypes = {
    sinker: PropTypes.object.isRequired,
    sinkerDisplayName: PropTypes.string.isRequired,

    onUpdateSinkerName: PropTypes.func.isRequired,
    onUpdateBlobConnection: PropTypes.func.isRequired,
    onUpdateBlobContainerName: PropTypes.func.isRequired,
    onUpdateBlobPrefix: PropTypes.func.isRequired,
    onUpdateBlobPartitionFormat: PropTypes.func.isRequired,
    onUpdateFormatType: PropTypes.func.isRequired,
    onUpdateCompressionType: PropTypes.func.isRequired
};

// Styles
const rootStyle = {
    paddingLeft: 30,
    paddingRight: 30,
    paddingBottom: 30
};

const sinkTypeSection = {
    paddingBottom: 40
};

const sectionStyle = {
    paddingBottom: 15
};
