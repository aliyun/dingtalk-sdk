<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\ListOrgTextEmotionResponseBody\result;

use AlibabaCloud\Tea\Model;

class emotions extends Model
{
    /**
     * @description 展示在消息气泡中的文字表情的mediaId
     *
     * @var string
     */
    public $backgroundMediaId;

    /**
     * @description 展示在消息长按菜单中的文字表情的mediaId
     *
     * @var string
     */
    public $backgroundMediaIdForPanel;

    /**
     * @description 表情所属部门Id：
     * 一级部门Id：该表情为一级部门层面的文字表情
     * @var int
     */
    public $deptId;

    /**
     * @description 表情Id
     *
     * @var string
     */
    public $emotionId;

    /**
     * @description 表情名称，对用户不可见
     *
     * @var string
     */
    public $emotionName;

    /**
     * @description 表情状态
     * 2：安全审核不通过
     * @var int
     */
    public $status;
    protected $_name = [
        'backgroundMediaId'         => 'backgroundMediaId',
        'backgroundMediaIdForPanel' => 'backgroundMediaIdForPanel',
        'deptId'                    => 'deptId',
        'emotionId'                 => 'emotionId',
        'emotionName'               => 'emotionName',
        'status'                    => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->backgroundMediaId) {
            $res['backgroundMediaId'] = $this->backgroundMediaId;
        }
        if (null !== $this->backgroundMediaIdForPanel) {
            $res['backgroundMediaIdForPanel'] = $this->backgroundMediaIdForPanel;
        }
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->emotionId) {
            $res['emotionId'] = $this->emotionId;
        }
        if (null !== $this->emotionName) {
            $res['emotionName'] = $this->emotionName;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return emotions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['backgroundMediaId'])) {
            $model->backgroundMediaId = $map['backgroundMediaId'];
        }
        if (isset($map['backgroundMediaIdForPanel'])) {
            $model->backgroundMediaIdForPanel = $map['backgroundMediaIdForPanel'];
        }
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['emotionId'])) {
            $model->emotionId = $map['emotionId'];
        }
        if (isset($map['emotionName'])) {
            $model->emotionName = $map['emotionName'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
