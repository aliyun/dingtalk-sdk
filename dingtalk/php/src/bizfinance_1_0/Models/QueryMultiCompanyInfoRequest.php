<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryMultiCompanyInfoRequest extends Model
{
    /**
     * @var bool
     */
    public $startStatus;
    protected $_name = [
        'startStatus' => 'startStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->startStatus) {
            $res['startStatus'] = $this->startStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryMultiCompanyInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['startStatus'])) {
            $model->startStatus = $map['startStatus'];
        }

        return $model;
    }
}
