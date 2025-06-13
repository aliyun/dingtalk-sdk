<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\ContractAiReviewResultNotifyRequest\annotations;
use AlibabaCloud\Tea\Model;

class ContractAiReviewResultNotifyRequest extends Model
{
    /**
     * @var annotations[]
     */
    public $annotations;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $contractAiReviewCorpId;

    /**
     * @var int
     */
    public $contractAiReviewId;

    /**
     * @var string
     */
    public $errorCode;

    /**
     * @var string
     */
    public $errorMsg;

    /**
     * @var string
     */
    public $extension;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'annotations' => 'annotations',
        'contractAiReviewCorpId' => 'contractAiReviewCorpId',
        'contractAiReviewId' => 'contractAiReviewId',
        'errorCode' => 'errorCode',
        'errorMsg' => 'errorMsg',
        'extension' => 'extension',
        'success' => 'success',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->annotations) {
            $res['annotations'] = [];
            if (null !== $this->annotations && \is_array($this->annotations)) {
                $n = 0;
                foreach ($this->annotations as $item) {
                    $res['annotations'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->contractAiReviewCorpId) {
            $res['contractAiReviewCorpId'] = $this->contractAiReviewCorpId;
        }
        if (null !== $this->contractAiReviewId) {
            $res['contractAiReviewId'] = $this->contractAiReviewId;
        }
        if (null !== $this->errorCode) {
            $res['errorCode'] = $this->errorCode;
        }
        if (null !== $this->errorMsg) {
            $res['errorMsg'] = $this->errorMsg;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ContractAiReviewResultNotifyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['annotations'])) {
            if (!empty($map['annotations'])) {
                $model->annotations = [];
                $n = 0;
                foreach ($map['annotations'] as $item) {
                    $model->annotations[$n++] = null !== $item ? annotations::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['contractAiReviewCorpId'])) {
            $model->contractAiReviewCorpId = $map['contractAiReviewCorpId'];
        }
        if (isset($map['contractAiReviewId'])) {
            $model->contractAiReviewId = $map['contractAiReviewId'];
        }
        if (isset($map['errorCode'])) {
            $model->errorCode = $map['errorCode'];
        }
        if (isset($map['errorMsg'])) {
            $model->errorMsg = $map['errorMsg'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
