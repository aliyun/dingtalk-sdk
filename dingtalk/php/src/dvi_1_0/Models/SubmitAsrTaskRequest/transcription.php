<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitAsrTaskRequest;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitAsrTaskRequest\transcription\diarization;
use AlibabaCloud\Tea\Model;

class transcription extends Model
{
    /**
     * @var diarization
     */
    public $diarization;

    /**
     * @var bool
     */
    public $diarizationEnabled;
    protected $_name = [
        'diarization' => 'diarization',
        'diarizationEnabled' => 'diarizationEnabled',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->diarization) {
            $res['diarization'] = null !== $this->diarization ? $this->diarization->toMap() : null;
        }
        if (null !== $this->diarizationEnabled) {
            $res['diarizationEnabled'] = $this->diarizationEnabled;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return transcription
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['diarization'])) {
            $model->diarization = diarization::fromMap($map['diarization']);
        }
        if (isset($map['diarizationEnabled'])) {
            $model->diarizationEnabled = $map['diarizationEnabled'];
        }

        return $model;
    }
}
