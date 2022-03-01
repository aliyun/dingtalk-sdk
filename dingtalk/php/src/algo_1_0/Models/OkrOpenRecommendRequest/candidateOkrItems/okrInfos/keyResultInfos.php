<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendRequest\candidateOkrItems\okrInfos;

use AlibabaCloud\Tea\Model;

class keyResultInfos extends Model
{
    /**
     * @var string
     */
    public $kr;

    /**
     * @var string
     */
    public $krId;

    /**
     * @var string[]
     */
    public $words;
    protected $_name = [
        'kr'    => 'kr',
        'krId'  => 'krId',
        'words' => 'words',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->kr) {
            $res['kr'] = $this->kr;
        }
        if (null !== $this->krId) {
            $res['krId'] = $this->krId;
        }
        if (null !== $this->words) {
            $res['words'] = $this->words;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return keyResultInfos
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['kr'])) {
            $model->kr = $map['kr'];
        }
        if (isset($map['krId'])) {
            $model->krId = $map['krId'];
        }
        if (isset($map['words'])) {
            if (!empty($map['words'])) {
                $model->words = $map['words'];
            }
        }

        return $model;
    }
}
