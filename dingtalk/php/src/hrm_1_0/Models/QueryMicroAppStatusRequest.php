<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryMicroAppStatusRequest extends Model
{
    /**
     * @var int[]
     */
    public $tenantIdList;
    protected $_name = [
        'tenantIdList' => 'tenantIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->tenantIdList) {
            $res['tenantIdList'] = $this->tenantIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryMicroAppStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tenantIdList'])) {
            if (!empty($map['tenantIdList'])) {
                $model->tenantIdList = $map['tenantIdList'];
            }
        }

        return $model;
    }
}
