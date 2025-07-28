<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\AddDomainWordsRequest;

use AlibabaCloud\Tea\Model;

class domainWords extends Model
{
    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $domainWord;

    /**
     * @var string[]
     */
    public $formalWords;
    protected $_name = [
        'description' => 'description',
        'domainWord' => 'domainWord',
        'formalWords' => 'formalWords',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->domainWord) {
            $res['domainWord'] = $this->domainWord;
        }
        if (null !== $this->formalWords) {
            $res['formalWords'] = $this->formalWords;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return domainWords
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['domainWord'])) {
            $model->domainWord = $map['domainWord'];
        }
        if (isset($map['formalWords'])) {
            if (!empty($map['formalWords'])) {
                $model->formalWords = $map['formalWords'];
            }
        }

        return $model;
    }
}
