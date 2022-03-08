<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class SortUserRequest extends Model
{
    /**
     * @description 0 根据姓名拼音升序排列 1 根据姓名拼音降序排列
     *
     * @var int
     */
    public $sortType;

    /**
     * @description 用户id列表
     *
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'sortType'   => 'sortType',
        'userIdList' => 'userIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sortType) {
            $res['sortType'] = $this->sortType;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
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
        if (isset($map['sortType'])) {
            $model->sortType = $map['sortType'];
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
