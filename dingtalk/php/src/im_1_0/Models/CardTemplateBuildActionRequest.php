<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class CardTemplateBuildActionRequest extends Model
{
    /**
     * @var string
     */
    public $action;

    /**
     * @example merge
     *
     * @var string
     */
    public $cardTemplateJson;
    protected $_name = [
        'action'           => 'action',
        'cardTemplateJson' => 'cardTemplateJson',
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
        if (null !== $this->cardTemplateJson) {
            $res['cardTemplateJson'] = $this->cardTemplateJson;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CardTemplateBuildActionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['action'])) {
            $model->action = $map['action'];
        }
        if (isset($map['cardTemplateJson'])) {
            $model->cardTemplateJson = $map['cardTemplateJson'];
        }

        return $model;
    }
}
