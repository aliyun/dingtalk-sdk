<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddOrgTextEmotionRequest extends Model
{
    /**
     * @description 展示在消息气泡上的表情的mediaId，mediaId可以通过使用文件上传接口上传表情图片得到，图片上限为500KB。
     *
     * 请严格按照表情设计规范设计表情，服务端会检查图片的大小、宽度、高度是否符合规范。
     * @var string
     */
    public $backgroundMediaId;

    /**
     * @description 展示在消息长按菜单的表情的mediaId，mediaId可以通过使用文件上传接口上传表情图片得到，图片上限为500KB。
     *
     * 请严格按照表情设计规范设计表情，服务端会检查图片的大小、宽度、高度是否符合规范。
     * @var string
     */
    public $backgroundMediaIdForPanel;

    /**
     * @description 部门Id，设置规则：
     *
     * 一级部门Id：当添加一级部门层面的文字表情时使用一级部门Id，此时表情对该一级部门及该一级部门下的所有子部门的员工可见
     * @var int
     */
    public $deptId;

    /**
     * @description 表情名称，对用户不可见
     *
     * @var string
     */
    public $emotionName;
    protected $_name = [
        'backgroundMediaId'         => 'backgroundMediaId',
        'backgroundMediaIdForPanel' => 'backgroundMediaIdForPanel',
        'deptId'                    => 'deptId',
        'emotionName'               => 'emotionName',
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
        if (null !== $this->emotionName) {
            $res['emotionName'] = $this->emotionName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddOrgTextEmotionRequest
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
        if (isset($map['emotionName'])) {
            $model->emotionName = $map['emotionName'];
        }

        return $model;
    }
}
