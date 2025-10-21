<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitAsrTaskRequest\transcription;
use AlibabaCloud\Tea\Model;

class SubmitAsrTaskRequest extends Model
{
    /**
     * @var string
     */
    public $bizKey;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $dentryId;

    /**
     * @var string[]
     */
    public $phrases;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $sourceLanguage;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $spaceId;

    /**
     * @var transcription
     */
    public $transcription;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'bizKey' => 'bizKey',
        'dentryId' => 'dentryId',
        'phrases' => 'phrases',
        'sourceLanguage' => 'sourceLanguage',
        'spaceId' => 'spaceId',
        'transcription' => 'transcription',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizKey) {
            $res['bizKey'] = $this->bizKey;
        }
        if (null !== $this->dentryId) {
            $res['dentryId'] = $this->dentryId;
        }
        if (null !== $this->phrases) {
            $res['phrases'] = $this->phrases;
        }
        if (null !== $this->sourceLanguage) {
            $res['sourceLanguage'] = $this->sourceLanguage;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }
        if (null !== $this->transcription) {
            $res['transcription'] = null !== $this->transcription ? $this->transcription->toMap() : null;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SubmitAsrTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizKey'])) {
            $model->bizKey = $map['bizKey'];
        }
        if (isset($map['dentryId'])) {
            $model->dentryId = $map['dentryId'];
        }
        if (isset($map['phrases'])) {
            if (!empty($map['phrases'])) {
                $model->phrases = $map['phrases'];
            }
        }
        if (isset($map['sourceLanguage'])) {
            $model->sourceLanguage = $map['sourceLanguage'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }
        if (isset($map['transcription'])) {
            $model->transcription = transcription::fromMap($map['transcription']);
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
