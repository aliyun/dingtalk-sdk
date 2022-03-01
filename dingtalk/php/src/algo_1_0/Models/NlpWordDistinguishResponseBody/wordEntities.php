<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\NlpWordDistinguishResponseBody;

use AlibabaCloud\Tea\Model;

class wordEntities extends Model
{
    /**
     * @var string
     */
    public $word;
    protected $_name = [
        'word' => 'word',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->word) {
            $res['word'] = $this->word;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return wordEntities
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['word'])) {
            $model->word = $map['word'];
        }

        return $model;
    }
}
