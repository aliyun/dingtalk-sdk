<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateAICardRequest\a2uiAnnotations;
use AlibabaCloud\Tea\Model;

class UpdateAICardRequest extends Model
{
    /**
     * @var a2uiAnnotations[]
     */
    public $a2uiAnnotations;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $a2uiMessages;

    /**
     * @description This parameter is required.
     *
     * @example PROCESSING
     *
     * @var string
     */
    public $flowStatus;

    /**
     * @description This parameter is required.
     *
     * @example a2ui_order_001
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @description This parameter is required.
     *
     * @example update_001
     *
     * @var string
     */
    public $outUpdateId;
    protected $_name = [
        'a2uiAnnotations' => 'a2uiAnnotations',
        'a2uiMessages' => 'a2uiMessages',
        'flowStatus' => 'flowStatus',
        'outTrackId' => 'outTrackId',
        'outUpdateId' => 'outUpdateId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->a2uiAnnotations) {
            $res['a2uiAnnotations'] = [];
            if (null !== $this->a2uiAnnotations && \is_array($this->a2uiAnnotations)) {
                $n = 0;
                foreach ($this->a2uiAnnotations as $item) {
                    $res['a2uiAnnotations'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->a2uiMessages) {
            $res['a2uiMessages'] = $this->a2uiMessages;
        }
        if (null !== $this->flowStatus) {
            $res['flowStatus'] = $this->flowStatus;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->outUpdateId) {
            $res['outUpdateId'] = $this->outUpdateId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateAICardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['a2uiAnnotations'])) {
            if (!empty($map['a2uiAnnotations'])) {
                $model->a2uiAnnotations = [];
                $n = 0;
                foreach ($map['a2uiAnnotations'] as $item) {
                    $model->a2uiAnnotations[$n++] = null !== $item ? a2uiAnnotations::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['a2uiMessages'])) {
            if (!empty($map['a2uiMessages'])) {
                $model->a2uiMessages = $map['a2uiMessages'];
            }
        }
        if (isset($map['flowStatus'])) {
            $model->flowStatus = $map['flowStatus'];
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['outUpdateId'])) {
            $model->outUpdateId = $map['outUpdateId'];
        }

        return $model;
    }
}
