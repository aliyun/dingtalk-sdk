<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\Tea\Model;

class CardTemplateBuildActionResponseBody extends Model
{
    /**
     * @description 模板构建的dto对象
     *
     * @var string
     */
    public $cardTemplateJson;
    protected $_name = [
        'cardTemplateJson' => 'cardTemplateJson',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardTemplateJson) {
            $res['cardTemplateJson'] = $this->cardTemplateJson;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CardTemplateBuildActionResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardTemplateJson'])) {
            $model->cardTemplateJson = $map['cardTemplateJson'];
        }

        return $model;
    }
}
