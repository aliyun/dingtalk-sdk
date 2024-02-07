<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoFaqListResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example 办公室电话是：13223333233
     *
     * @var string
     */
    public $answer;

    /**
     * @example xxxx
     *
     * @var string
     */
    public $bizId;

    /**
     * @example yyyyyy-aaaaaa-bbbbb-cccccccccc.docx
     *
     * @var string
     */
    public $mediaId;

    /**
     * @example 办公室电话是多少
     *
     * @var string
     */
    public $question;

    /**
     * @example http://www.dingtalk.com/
     *
     * @var string
     */
    public $redirection;
    protected $_name = [
        'answer'      => 'answer',
        'bizId'       => 'bizId',
        'mediaId'     => 'mediaId',
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
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
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
     * @return data
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
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
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
