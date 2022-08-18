<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryOfficialDataRequest extends Model
{
    /**
     * @var string
     */
    public $param;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'param'  => 'param',
        'userId' => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->param) {
            $res['param'] = $this->param;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryOfficialDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['param'])) {
            $model->param = $map['param'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
