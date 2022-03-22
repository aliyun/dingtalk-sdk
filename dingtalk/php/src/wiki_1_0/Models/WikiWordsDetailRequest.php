<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_1_0\Models;

use AlibabaCloud\Tea\Model;

class WikiWordsDetailRequest extends Model
{
    /**
     * @description 传递的词条名称
     *
     * @var string
     */
    public $wordName;
    protected $_name = [
        'wordName' => 'wordName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->wordName) {
            $res['wordName'] = $this->wordName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return WikiWordsDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['wordName'])) {
            $model->wordName = $map['wordName'];
        }

        return $model;
    }
}
