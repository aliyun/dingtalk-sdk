<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models\CreateTodoTypeConfigResponseBody;

use AlibabaCloud\Tea\Model;

class actionList extends Model
{
    /**
     * @var string
     */
    public $actionKey;

    /**
     * @var int
     */
    public $actionType;

    /**
     * @var int
     */
    public $buttonStyleType;

    /**
     * @var mixed[]
     */
    public $nameI18n;

    /**
     * @var string
     */
    public $url;
    protected $_name = [
        'actionKey'       => 'actionKey',
        'actionType'      => 'actionType',
        'buttonStyleType' => 'buttonStyleType',
        'nameI18n'        => 'nameI18n',
        'url'             => 'url',
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
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->buttonStyleType) {
            $res['buttonStyleType'] = $this->buttonStyleType;
        }
        if (null !== $this->nameI18n) {
            $res['nameI18n'] = $this->nameI18n;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
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
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['buttonStyleType'])) {
            $model->buttonStyleType = $map['buttonStyleType'];
        }
        if (isset($map['nameI18n'])) {
            $model->nameI18n = $map['nameI18n'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
