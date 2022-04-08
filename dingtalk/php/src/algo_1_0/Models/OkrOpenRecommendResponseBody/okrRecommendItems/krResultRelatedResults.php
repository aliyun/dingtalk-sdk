<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendResponseBody\okrRecommendItems;

use AlibabaCloud\Tea\Model;

class krResultRelatedResults extends Model
{
    /**
     * @description krId
     *
     * @var string
     */
    public $krId;

    /**
     * @description semanticLevel
     *
     * @var int
     */
    public $semanticLevel;

    /**
     * @description words
     *
     * @var string[]
     */
    public $words;
    protected $_name = [
        'krId'          => 'krId',
        'semanticLevel' => 'semanticLevel',
        'words'         => 'words',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->krId) {
            $res['krId'] = $this->krId;
        }
        if (null !== $this->semanticLevel) {
            $res['semanticLevel'] = $this->semanticLevel;
        }
        if (null !== $this->words) {
            $res['words'] = $this->words;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return krResultRelatedResults
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['krId'])) {
            $model->krId = $map['krId'];
        }
        if (isset($map['semanticLevel'])) {
            $model->semanticLevel = $map['semanticLevel'];
        }
        if (isset($map['words'])) {
            if (!empty($map['words'])) {
                $model->words = $map['words'];
            }
        }

        return $model;
    }
}
