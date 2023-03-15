<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\GetFileUploadInfoResponseBody\headerSignatureInfo;
use AlibabaCloud\Tea\Model;

class GetFileUploadInfoResponseBody extends Model
{
    /**
     * @description Header加签上传信息, 当protocol等于HEADER_SIGNATURE时，此字段生效
     *
     * @var headerSignatureInfo
     */
    public $headerSignatureInfo;

    /**
     * @description 上传协议，根据不同上传类型返回对应的信息.
     * HEADER_SIGNATURE: Header加签
     * @var string
     */
    public $protocol;

    /**
     * @description 文件存储类型
     * UNKNOWN: 未知驱动
     * @var string
     */
    public $storageDriver;

    /**
     * @description 上传唯一标识
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
