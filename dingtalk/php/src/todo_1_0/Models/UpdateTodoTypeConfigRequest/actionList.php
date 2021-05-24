<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\UpdateTodoTypeConfigRequest;

use AlibabaCloud\Tea\Model;

class actionList extends Model
{
    /**
     * @description 操作按钮的唯一标识
     *
     * @var string
     */
    public $actionKey;

    /**
     * @description 按钮样式类型（101：蓝色线型主按钮样式，例如「同意」，102：黑色线型副按钮样式，例如「拒绝」）
     *
     * @var int
     */
    public $buttonStyleType;

    /**
     * @description 按钮类型（1：有操作的，2：直接跳转）
     *
     * @var int
     */
    public $actionType;

    /**
     * @description 按钮类型为直接跳转时，对应的跳转url
     *
     * @var string
     */
    public $url;

    /**
     * @description 按钮操作的显示名称（需支持国际化）
     *
     * @var mixed[]
     */
    public $nameI18n;
    protected $_name = [
        'actionKey'       => 'actionKey',
        'buttonStyleType' => 'buttonStyleType',
        'actionType'      => 'actionType',
        'url'             => 'url',
        'nameI18n'        => 'nameI18n',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionKey) {
            $res['actionKey'] = $this->actionKey;
        }
        if (null !== $this->buttonStyleType) {
            $res['buttonStyleType'] = $this->buttonStyleType;
        }
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }
        if (null !== $this->nameI18n) {
            $res['nameI18n'] = $this->nameI18n;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return actionList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionKey'])) {
            $model->actionKey = $map['actionKey'];
        }
        if (isset($map['buttonStyleType'])) {
            $model->buttonStyleType = $map['buttonStyleType'];
        }
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }
        if (isset($map['nameI18n'])) {
            $model->nameI18n = $map['nameI18n'];
        }

        return $model;
    }
}
