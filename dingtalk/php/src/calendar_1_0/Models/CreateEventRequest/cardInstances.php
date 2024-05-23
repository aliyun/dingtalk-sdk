<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\CreateEventRequest;

use AlibabaCloud\Tea\Model;

class cardInstances extends Model
{
    /**
     * @var string
     */
    public $outTrackId;

    /**
     * @var string
     */
    public $scenario;
    protected $_name = [
        'outTrackId' => 'outTrackId',
        'scenario'   => 'scenario',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->scenario) {
            $res['scenario'] = $this->scenario;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cardInstances
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['scenario'])) {
            $model->scenario = $map['scenario'];
        }

        return $model;
    }
}
