<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class QueryBranchRequest extends Model
{
    /**
     * @var string
     */
    public $bankName;

    /**
     * @var string
     */
    public $city;

    /**
     * @var string
     */
    public $province;
    protected $_name = [
        'bankName' => 'bankName',
        'city' => 'city',
        'province' => 'province',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bankName) {
            $res['bankName'] = $this->bankName;
        }
        if (null !== $this->city) {
            $res['city'] = $this->city;
        }
        if (null !== $this->province) {
            $res['province'] = $this->province;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryBranchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bankName'])) {
            $model->bankName = $map['bankName'];
        }
        if (isset($map['city'])) {
            $model->city = $map['city'];
        }
        if (isset($map['province'])) {
            $model->province = $map['province'];
        }

        return $model;
    }
}
