<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vvillage_1_0\Models\GetUserResponseBody\unionEmpExt;

use AlibabaCloud\Tea\Model;

class unionEmpMapList extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $staffId;
    protected $_name = [
        'corpId'  => 'corpId',
        'staffId' => 'staffId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->staffId) {
            $res['staffId'] = $this->staffId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return unionEmpMapList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['staffId'])) {
            $model->staffId = $map['staffId'];
        }

        return $model;
    }
}
