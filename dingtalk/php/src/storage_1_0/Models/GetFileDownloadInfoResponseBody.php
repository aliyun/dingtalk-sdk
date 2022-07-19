<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetFileDownloadInfoResponseBody\headerSignatureInfo;
use AlibabaCloud\Tea\Model;

class GetFileDownloadInfoResponseBody extends Model
{
    /**
     * @description Header加签信息, 当protocol等于HEADER_SIGNATURE时，此字段生效
     *
     * @var headerSignatureInfo
     */
    public $headerSignatureInfo;

    /**
     * @description 文件下载协议
     * HEADER_SIGNATURE: Header加签
     * @var string
     */
    public $protocol;
    protected $_name = [
        'headerSignatureInfo' => 'headerSignatureInfo',
        'protocol'            => 'protocol',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetFileDownloadInfoResponseBody
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

        return $model;
    }
}
