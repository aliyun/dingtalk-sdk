<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateRequest\data;

use AlibabaCloud\Tea\Model;

class cardRuleItemParamList extends Model
{
    /**
     * @var string
     */
    public $cardRuleAttr;

    /**
     * @var string
     */
    public $cardTaskCode;

    /**
     * @var int
     */
    public $dailyDubbing;

    /**
     * @var string
     */
    public $relationId;

    /**
     * @var string
     */
    public $relationTitle;

    /**
     * @var string
     */
    public $relationUrl;
    protected $_name = [
        'cardRuleAttr'  => 'cardRuleAttr',
        'cardTaskCode'  => 'cardTaskCode',
        'dailyDubbing'  => 'dailyDubbing',
        'relationId'    => 'relationId',
        'relationTitle' => 'relationTitle',
        'relationUrl'   => 'relationUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardRuleAttr) {
            $res['cardRuleAttr'] = $this->cardRuleAttr;
        }
        if (null !== $this->cardTaskCode) {
            $res['cardTaskCode'] = $this->cardTaskCode;
        }
        if (null !== $this->dailyDubbing) {
            $res['dailyDubbing'] = $this->dailyDubbing;
        }
        if (null !== $this->relationId) {
            $res['relationId'] = $this->relationId;
        }
        if (null !== $this->relationTitle) {
            $res['relationTitle'] = $this->relationTitle;
        }
        if (null !== $this->relationUrl) {
            $res['relationUrl'] = $this->relationUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cardRuleItemParamList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardRuleAttr'])) {
            $model->cardRuleAttr = $map['cardRuleAttr'];
        }
        if (isset($map['cardTaskCode'])) {
            $model->cardTaskCode = $map['cardTaskCode'];
        }
        if (isset($map['dailyDubbing'])) {
            $model->dailyDubbing = $map['dailyDubbing'];
        }
        if (isset($map['relationId'])) {
            $model->relationId = $map['relationId'];
        }
        if (isset($map['relationTitle'])) {
            $model->relationTitle = $map['relationTitle'];
        }
        if (isset($map['relationUrl'])) {
            $model->relationUrl = $map['relationUrl'];
        }

        return $model;
    }
}
