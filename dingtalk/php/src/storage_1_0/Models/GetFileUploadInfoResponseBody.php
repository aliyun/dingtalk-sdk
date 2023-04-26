<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetFileUploadInfoResponseBody\headerSignatureInfo;
use AlibabaCloud\Tea\Model;

class GetFileUploadInfoResponseBody extends Model
{
    /**
     * @var headerSignatureInfo
     */
    public $headerSignatureInfo;

    /**
     * @example HEADER_SIGNATURE
     *
     * @var string
     */
    public $protocol;

    /**
     * @example DINGTALK
     *
     * @var string
     */
    public $storageDriver;

    /**
     * @example upload_key
     *
     * @var string
     */
    public $uploadKey;
    protected $_name = [
        'headerSignatureInfo' => 'headerSignatureInfo',
        'protocol'            => 'protocol',
        'storageDriver'       => 'storageDriver',
        'uploadKey'           => 'uploadKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->headerSignatureInfo) {
            $res['headerSignatureInfo'] = null !== $this->headerSignatureInfo ? $this->headerSignatureInfo->toMap() : null;
        }
        if (null !== $this->protocol) {
            $res['protocol'] = $this->protocol;
        }
        if (null !== $this->storageDriver) {
            $res['storageDriver'] = $this->storageDriver;
        }
        if (null !== $this->uploadKey) {
            $res['uploadKey'] = $this->uploadKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFileUploadInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['headerSignatureInfo'])) {
            $model->headerSignatureInfo = headerSignatureInfo::fromMap($map['headerSignatureInfo']);
        }
        if (isset($map['protocol'])) {
            $model->protocol = $map['protocol'];
        }
        if (isset($map['storageDriver'])) {
            $model->storageDriver = $map['storageDriver'];
        }
        if (isset($map['uploadKey'])) {
            $model->uploadKey = $map['uploadKey'];
        }

        return $model;
    }
}
