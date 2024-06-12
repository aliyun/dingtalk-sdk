<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesSummaryResponseBody\summary;

use AlibabaCloud\Tea\Model;

class conversationalSummary extends Model
{
    /**
     * @var string
     */
    public $speakerId;

    /**
     * @var string
     */
    public $speakerName;

    /**
     * @var string
     */
    public $summary;
    protected $_name = [
        'speakerId'   => 'speakerId',
        'speakerName' => 'speakerName',
        'summary'     => 'summary',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->speakerId) {
            $res['speakerId'] = $this->speakerId;
        }
        if (null !== $this->speakerName) {
            $res['speakerName'] = $this->speakerName;
        }
        if (null !== $this->summary) {
            $res['summary'] = $this->summary;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return conversationalSummary
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['speakerId'])) {
            $model->speakerId = $map['speakerId'];
        }
        if (isset($map['speakerName'])) {
            $model->speakerName = $map['speakerName'];
        }
        if (isset($map['summary'])) {
            $model->summary = $map['summary'];
        }

        return $model;
    }
}
