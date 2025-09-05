<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryEnterpriseCodeOpenDetailResponseBody extends Model
{
    /**
     * @var string
     */
    public $enterpriseId;

    /**
     * @var bool
     */
    public $openedStatus;
    protected $_name = [
        'enterpriseId' => 'enterpriseId',
        'openedStatus' => 'openedStatus',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->enterpriseId) {
            $res['enterpriseId'] = $this->enterpriseId;
        }
        if (null !== $this->openedStatus) {
            $res['openedStatus'] = $this->openedStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryEnterpriseCodeOpenDetailResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enterpriseId'])) {
            $model->enterpriseId = $map['enterpriseId'];
        }
        if (isset($map['openedStatus'])) {
            $model->openedStatus = $map['openedStatus'];
        }

        return $model;
    }
}
