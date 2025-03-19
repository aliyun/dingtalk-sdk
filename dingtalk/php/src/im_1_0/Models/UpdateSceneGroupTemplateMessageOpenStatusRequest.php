<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateSceneGroupTemplateMessageOpenStatusRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $status;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $templateIdList;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'status' => 'status',
        'templateIdList' => 'templateIdList',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->templateIdList) {
            $res['templateIdList'] = $this->templateIdList;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateSceneGroupTemplateMessageOpenStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['templateIdList'])) {
            if (!empty($map['templateIdList'])) {
                $model->templateIdList = $map['templateIdList'];
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
