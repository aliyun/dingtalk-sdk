<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class HospitalDataCheckResponseBody extends Model
{
    /**
     * @var int
     */
    public $allDeptCount;

    /**
     * @var int
     */
    public $allDeptUserCount;

    /**
     * @var int
     */
    public $allGroupCount;

    /**
     * @var int
     */
    public $allGroupUserCount;

    /**
     * @var int
     */
    public $deptCount;

    /**
     * @var int
     */
    public $deptUserCount;

    /**
     * @var int
     */
    public $groupCount;

    /**
     * @var int
     */
    public $groupUserCount;

    /**
     * @var bool
     */
    public $match;
    protected $_name = [
        'allDeptCount'      => 'allDeptCount',
        'allDeptUserCount'  => 'allDeptUserCount',
        'allGroupCount'     => 'allGroupCount',
        'allGroupUserCount' => 'allGroupUserCount',
        'deptCount'         => 'deptCount',
        'deptUserCount'     => 'deptUserCount',
        'groupCount'        => 'groupCount',
        'groupUserCount'    => 'groupUserCount',
        'match'             => 'match',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->allDeptCount) {
            $res['allDeptCount'] = $this->allDeptCount;
        }
        if (null !== $this->allDeptUserCount) {
            $res['allDeptUserCount'] = $this->allDeptUserCount;
        }
        if (null !== $this->allGroupCount) {
            $res['allGroupCount'] = $this->allGroupCount;
        }
        if (null !== $this->allGroupUserCount) {
            $res['allGroupUserCount'] = $this->allGroupUserCount;
        }
        if (null !== $this->deptCount) {
            $res['deptCount'] = $this->deptCount;
        }
        if (null !== $this->deptUserCount) {
            $res['deptUserCount'] = $this->deptUserCount;
        }
        if (null !== $this->groupCount) {
            $res['groupCount'] = $this->groupCount;
        }
        if (null !== $this->groupUserCount) {
            $res['groupUserCount'] = $this->groupUserCount;
        }
        if (null !== $this->match) {
            $res['match'] = $this->match;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return HospitalDataCheckResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['allDeptCount'])) {
            $model->allDeptCount = $map['allDeptCount'];
        }
        if (isset($map['allDeptUserCount'])) {
            $model->allDeptUserCount = $map['allDeptUserCount'];
        }
        if (isset($map['allGroupCount'])) {
            $model->allGroupCount = $map['allGroupCount'];
        }
        if (isset($map['allGroupUserCount'])) {
            $model->allGroupUserCount = $map['allGroupUserCount'];
        }
        if (isset($map['deptCount'])) {
            $model->deptCount = $map['deptCount'];
        }
        if (isset($map['deptUserCount'])) {
            $model->deptUserCount = $map['deptUserCount'];
        }
        if (isset($map['groupCount'])) {
            $model->groupCount = $map['groupCount'];
        }
        if (isset($map['groupUserCount'])) {
            $model->groupUserCount = $map['groupUserCount'];
        }
        if (isset($map['match'])) {
            $model->match = $map['match'];
        }

        return $model;
    }
}
