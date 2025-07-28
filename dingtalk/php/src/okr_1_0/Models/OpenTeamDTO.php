<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenTeamDTO extends Model
{
    /**
     * @example 0342464558835299
     *
     * @var string
     */
    public $deptUid;

    /**
     * @example 64cd2e9bb80efb17244c650d
     *
     * @var string
     */
    public $dingDeptId;

    /**
     * @example xx部门
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'deptUid' => 'deptUid',
        'dingDeptId' => 'dingDeptId',
        'name' => 'name',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptUid) {
            $res['deptUid'] = $this->deptUid;
        }
        if (null !== $this->dingDeptId) {
            $res['dingDeptId'] = $this->dingDeptId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenTeamDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptUid'])) {
            $model->deptUid = $map['deptUid'];
        }
        if (isset($map['dingDeptId'])) {
            $model->dingDeptId = $map['dingDeptId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
