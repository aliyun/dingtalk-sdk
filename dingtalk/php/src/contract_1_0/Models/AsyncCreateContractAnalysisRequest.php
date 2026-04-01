<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\AsyncCreateContractAnalysisRequest\fileInfo;
use AlibabaCloud\Tea\Model;

class AsyncCreateContractAnalysisRequest extends Model
{
    /**
     * @var fileInfo
     */
    public $fileInfo;

    /**
     * @var string
     */
    public $originatorUserId;
    protected $_name = [
        'fileInfo' => 'fileInfo',
        'originatorUserId' => 'originatorUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileInfo) {
            $res['fileInfo'] = null !== $this->fileInfo ? $this->fileInfo->toMap() : null;
        }
        if (null !== $this->originatorUserId) {
            $res['originatorUserId'] = $this->originatorUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AsyncCreateContractAnalysisRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileInfo'])) {
            $model->fileInfo = fileInfo::fromMap($map['fileInfo']);
        }
        if (isset($map['originatorUserId'])) {
            $model->originatorUserId = $map['originatorUserId'];
        }

        return $model;
    }
}
