<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverRequest;

use AlibabaCloud\Tea\Model;

class workBenchOpenDeliverModel extends Model
{
    /**
     * @description 【必填】组件icon对应组件左上角的图标
     *
     * @var string
     */
    public $icon;

    /**
     * @description 【必填】卡片名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 【必填】卡片组件名
     *
     * @var string
     */
    public $pluginComponentName;

    /**
     * @description 【必填】卡片预览图
     *
     * @var string
     */
    public $previewUrl;

    /**
     * @description 【必填】保持和微应用名称相同
     *
     * @var string
     */
    public $projectName;

    /**
     * @description 【必填】操作者Id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'icon'                => 'icon',
        'name'                => 'name',
        'pluginComponentName' => 'pluginComponentName',
        'previewUrl'          => 'previewUrl',
        'projectName'         => 'projectName',
        'userId'              => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->pluginComponentName) {
            $res['pluginComponentName'] = $this->pluginComponentName;
        }
        if (null !== $this->previewUrl) {
            $res['previewUrl'] = $this->previewUrl;
        }
        if (null !== $this->projectName) {
            $res['projectName'] = $this->projectName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return workBenchOpenDeliverModel
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['pluginComponentName'])) {
            $model->pluginComponentName = $map['pluginComponentName'];
        }
        if (isset($map['previewUrl'])) {
            $model->previewUrl = $map['previewUrl'];
        }
        if (isset($map['projectName'])) {
            $model->projectName = $map['projectName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
