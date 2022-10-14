<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetMultipartFileUploadInfosResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\GetMultipartFileUploadInfosResponseBody\multipartHeaderSignatureInfos\headerSignatureInfo;
use AlibabaCloud\Tea\Model;

class multipartHeaderSignatureInfos extends Model
{
    /**
     * @description header信息
     *
     * @var headerSignatureInfo
     */
    public $headerSignatureInfo;

    /**
     * @description 分片number
     *
     * @var int
     */
    public $partNumber;
    protected $_name = [
        'headerSignatureInfo' => 'headerSignatureInfo',
        'partNumber'          => 'partNumber',
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
        if (null !== $this->partNumber) {
            $res['partNumber'] = $this->partNumber;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return multipartHeaderSignatureInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['headerSignatureInfo'])) {
            $model->headerSignatureInfo = headerSignatureInfo::fromMap($map['headerSignatureInfo']);
        }
        if (isset($map['partNumber'])) {
            $model->partNumber = $map['partNumber'];
        }

        return $model;
    }
}
