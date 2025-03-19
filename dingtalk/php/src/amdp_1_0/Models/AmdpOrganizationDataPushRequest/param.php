<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vamdp_1_0\Models\AmdpOrganizationDataPushRequest;

use AlibabaCloud\Tea\Model;

class param extends Model
{
    /**
     * @var string
     */
    public $deptId;

    /**
     * @var string[]
     */
    public $deptManagerIdList;

    /**
     * @var string
     */
    public $dingTalkDeptId;

    /**
     * @var string
     */
    public $dingTalkParentId;

    /**
     * @var string
     */
    public $isDelete;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $parentId;
    protected $_name = [
        'deptId' => 'deptId',
        'deptManagerIdList' => 'deptManagerIdList',
        'dingTalkDeptId' => 'dingTalkDeptId',
        'dingTalkParentId' => 'dingTalkParentId',
        'isDelete' => 'isDelete',
        'name' => 'name',
        'parentId' => 'parentId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptManagerIdList) {
            $res['deptManagerIdList'] = $this->deptManagerIdList;
        }
        if (null !== $this->dingTalkDeptId) {
            $res['dingTalkDeptId'] = $this->dingTalkDeptId;
        }
        if (null !== $this->dingTalkParentId) {
            $res['dingTalkParentId'] = $this->dingTalkParentId;
        }
        if (null !== $this->isDelete) {
            $res['isDelete'] = $this->isDelete;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return param
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptManagerIdList'])) {
            if (!empty($map['deptManagerIdList'])) {
                $model->deptManagerIdList = $map['deptManagerIdList'];
            }
        }
        if (isset($map['dingTalkDeptId'])) {
            $model->dingTalkDeptId = $map['dingTalkDeptId'];
        }
        if (isset($map['dingTalkParentId'])) {
            $model->dingTalkParentId = $map['dingTalkParentId'];
        }
        if (isset($map['isDelete'])) {
            $model->isDelete = $map['isDelete'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }

        return $model;
    }
}
