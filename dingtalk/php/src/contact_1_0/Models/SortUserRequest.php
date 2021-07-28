<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class SortUserRequest extends Model
{
    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @description 用户id列表
     *
     * @var string[]
     */
    public $userIdList;

    /**
     * @description 0 根据姓名拼音升序排列 1 根据姓名拼音降序排列
     *
     * @var int
     */
    public $sortType;
    protected $_name = [
        'dingOrgId'  => 'dingOrgId',
        'userIdList' => 'userIdList',
        'sortType'   => 'sortType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }
        if (null !== $this->sortType) {
            $res['sortType'] = $this->sortType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SortUserRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }
        if (isset($map['sortType'])) {
            $model->sortType = $map['sortType'];
        }

        return $model;
    }
}
