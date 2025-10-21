<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitAsrTaskRequest\transcription;

use AlibabaCloud\Tea\Model;

class diarization extends Model
{
    /**
     * @var int
     */
    public $speakerCount;
    protected $_name = [
        'speakerCount' => 'speakerCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->speakerCount) {
            $res['speakerCount'] = $this->speakerCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return diarization
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['speakerCount'])) {
            $model->speakerCount = $map['speakerCount'];
        }

        return $model;
    }
}
