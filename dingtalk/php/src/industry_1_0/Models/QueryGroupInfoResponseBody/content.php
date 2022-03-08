<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryGroupInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryGroupInfoResponseBody\content\leader;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 科室Id
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 有效期结束时间
     *
     * @var int
     */
    public $endTime;

    /**
     * @description 医疗组Id
     *
     * @var int
     */
    public $id;

    /**
     * @description 医疗组组长
     *
     * @var leader
     */
    public $leader;

    /**
     * @description 医疗组名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 有效期开始时间
     *
     * @var int
     */
    public $startTime;
    protected $_name = [
        'deptId'    => 'deptId',
        'endTime'   => 'endTime',
        'id'        => 'id',
        'leader'    => 'leader',
        'name'      => 'name',
        'startTime' => 'startTime',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->leader) {
            $res['leader'] = null !== $this->leader ? $this->leader->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['leader'])) {
            $model->leader = leader::fromMap($map['leader']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }

        return $model;
    }
}
