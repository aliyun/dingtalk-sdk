<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteOrgTextEmotionRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example -1
     *
     * @var int
     */
    public $deptId;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $emotionIds;
    protected $_name = [
        'deptId' => 'deptId',
        'emotionIds' => 'emotionIds',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->emotionIds) {
            $res['emotionIds'] = $this->emotionIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteOrgTextEmotionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['emotionIds'])) {
            if (!empty($map['emotionIds'])) {
                $model->emotionIds = $map['emotionIds'];
            }
        }

        return $model;
    }
}
