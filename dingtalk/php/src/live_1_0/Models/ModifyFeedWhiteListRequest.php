<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ModifyFeedWhiteListRequest extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $action;

    /**
     * @var string[]
     */
    public $modifyUserList;

    /**
     * @example 1206186351746728
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'action'         => 'action',
        'modifyUserList' => 'modifyUserList',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->action) {
            $res['action'] = $this->action;
        }
        if (null !== $this->modifyUserList) {
            $res['modifyUserList'] = $this->modifyUserList;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ModifyFeedWhiteListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['modifyUserList'])) {
            if (!empty($map['modifyUserList'])) {
                $model->modifyUserList = $map['modifyUserList'];
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
