<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DigitalStoreUpdateAuthInfoRequest\updateUserList;

use AlibabaCloud\Tea\Model;

class userAuthList extends Model
{
    /**
     * @example 8733901123
     *
     * @var string
     */
    public $dingDeptId;

    /**
     * @example 998383831
     *
     * @var string
     */
    public $sourceDeptId;
    protected $_name = [
        'dingDeptId' => 'dingDeptId',
        'sourceDeptId' => 'sourceDeptId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingDeptId) {
            $res['dingDeptId'] = $this->dingDeptId;
        }
        if (null !== $this->sourceDeptId) {
            $res['sourceDeptId'] = $this->sourceDeptId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userAuthList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingDeptId'])) {
            $model->dingDeptId = $map['dingDeptId'];
        }
        if (isset($map['sourceDeptId'])) {
            $model->sourceDeptId = $map['sourceDeptId'];
        }

        return $model;
    }
}
