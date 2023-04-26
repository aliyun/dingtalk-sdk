<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\SendOTOInteractiveCardRequest;

use AlibabaCloud\Tea\Model;

class cardData extends Model
{
    /**
     * @var string[]
     */
    public $cardParamMap;
    protected $_name = [
        'cardParamMap' => 'cardParamMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardParamMap) {
            $res['cardParamMap'] = $this->cardParamMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cardData
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardParamMap'])) {
            $model->cardParamMap = $map['cardParamMap'];
        }

        return $model;
    }
}
