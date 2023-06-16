<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeductPointRequest extends Model
{
    /**
     * @example biz01
     *
     * @var string
     */
    public $bizId;

    /**
     * @example 兑换商品
     *
     * @var string
     */
    public $deductDesc;

    /**
     * @example https://www.dingtalk.com/
     *
     * @var string
     */
    public $deductDetailUrl;

    /**
     * @var int
     */
    public $deductNum;

    /**
     * @example personal
     *
     * @var string
     */
    public $pointType;
    protected $_name = [
        'bizId'           => 'bizId',
        'deductDesc'      => 'deductDesc',
        'deductDetailUrl' => 'deductDetailUrl',
        'deductNum'       => 'deductNum',
        'pointType'       => 'pointType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->deductDesc) {
            $res['deductDesc'] = $this->deductDesc;
        }
        if (null !== $this->deductDetailUrl) {
            $res['deductDetailUrl'] = $this->deductDetailUrl;
        }
        if (null !== $this->deductNum) {
            $res['deductNum'] = $this->deductNum;
        }
        if (null !== $this->pointType) {
            $res['pointType'] = $this->pointType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeductPointRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['deductDesc'])) {
            $model->deductDesc = $map['deductDesc'];
        }
        if (isset($map['deductDetailUrl'])) {
            $model->deductDetailUrl = $map['deductDetailUrl'];
        }
        if (isset($map['deductNum'])) {
            $model->deductNum = $map['deductNum'];
        }
        if (isset($map['pointType'])) {
            $model->pointType = $map['pointType'];
        }

        return $model;
    }
}
