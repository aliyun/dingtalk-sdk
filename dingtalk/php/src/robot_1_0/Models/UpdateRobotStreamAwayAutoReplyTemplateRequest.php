<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateRobotStreamAwayAutoReplyTemplateRequest extends Model
{
    /**
     * @var string
     */
    public $cardData;

    /**
     * @var string
     */
    public $cardTemplateId;

    /**
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'cardData' => 'cardData',
        'cardTemplateId' => 'cardTemplateId',
        'robotCode' => 'robotCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardData) {
            $res['cardData'] = $this->cardData;
        }
        if (null !== $this->cardTemplateId) {
            $res['cardTemplateId'] = $this->cardTemplateId;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateRobotStreamAwayAutoReplyTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardData'])) {
            $model->cardData = $map['cardData'];
        }
        if (isset($map['cardTemplateId'])) {
            $model->cardTemplateId = $map['cardTemplateId'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
