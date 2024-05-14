<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class ChatMemoFaqAddRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 办公室的电话是：13222333232
     *
     * @var string
     */
    public $answer;

    /**
     * @example aaaaa
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @example 111111
     *
     * @var int
     */
    public $datasetId;

    /**
     * @description This parameter is required.
     *
     * @example 办公室的电话是多少
     *
     * @var string
     */
    public $question;

    /**
     * @example https://xxxxxxx.com/xxxxxx
     *
     * @var string
     */
    public $redirection;
    protected $_name = [
        'answer'      => 'answer',
        'bizId'       => 'bizId',
        'datasetId'   => 'datasetId',
        'question'    => 'question',
        'redirection' => 'redirection',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->answer) {
            $res['answer'] = $this->answer;
        }
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->datasetId) {
            $res['datasetId'] = $this->datasetId;
        }
        if (null !== $this->question) {
            $res['question'] = $this->question;
        }
        if (null !== $this->redirection) {
            $res['redirection'] = $this->redirection;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChatMemoFaqAddRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['answer'])) {
            $model->answer = $map['answer'];
        }
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['datasetId'])) {
            $model->datasetId = $map['datasetId'];
        }
        if (isset($map['question'])) {
            $model->question = $map['question'];
        }
        if (isset($map['redirection'])) {
            $model->redirection = $map['redirection'];
        }

        return $model;
    }
}
