<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentInfoResponseBody\content\leader;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentInfoResponseBody\content\residentLeader;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 科室Id
     *
     * @var int
     */
    public $id;

    /**
     * @description 科室主任
     *
     * @var leader
     */
    public $leader;

    /**
     * @description 科室名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 住院总医师
     *
     * @var residentLeader
     */
    public $residentLeader;
    protected $_name = [
        'id'             => 'id',
        'leader'         => 'leader',
        'name'           => 'name',
        'residentLeader' => 'residentLeader',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->leader) {
            $res['leader'] = null !== $this->leader ? $this->leader->toMap() : null;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->residentLeader) {
            $res['residentLeader'] = null !== $this->residentLeader ? $this->residentLeader->toMap() : null;
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['leader'])) {
            $model->leader = leader::fromMap($map['leader']);
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['residentLeader'])) {
            $model->residentLeader = residentLeader::fromMap($map['residentLeader']);
        }

        return $model;
    }
}
