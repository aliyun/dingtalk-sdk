<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesAudioResponseBody;

use AlibabaCloud\Tea\Model;

class audioList extends Model
{
    /**
     * @example 59886
     *
     * @var int
     */
    public $duration;

    /**
     * @example 1631172094000
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 1127942
     *
     * @var int
     */
    public $fileSize;

    /**
     * @example https://xxx-hangzhou.oss-cn-hangzhou.aliyuncs.com/record_xxxx.mp3?Expires=1718045081&OSSAccessKeyId=TMP.3KdwHtvZxopmwacMZEdyb4WHLVmbArrNRB9CTKnR1MaJgmRjdmZczs6Rip66cgKgk2HhQon1yygvBnbY3uqEaZNeHBLcBa&Signature=OFWyAIY%2FdlzfwM9wIfEaKoAudkxxxxx
     *
     * @var string
     */
    public $playUrl;

    /**
     * @example 290882268xxx1172033231
     *
     * @var string
     */
    public $recordId;

    /**
     * @example 1631172094000
     *
     * @var int
     */
    public $startTime;

    /**
     * @example WFBkgJvtxxxxtSaA1jK4sgiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'duration' => 'duration',
        'endTime' => 'endTime',
        'fileSize' => 'fileSize',
        'playUrl' => 'playUrl',
        'recordId' => 'recordId',
        'startTime' => 'startTime',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->duration) {
            $res['duration'] = $this->duration;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->playUrl) {
            $res['playUrl'] = $this->playUrl;
        }
        if (null !== $this->recordId) {
            $res['recordId'] = $this->recordId;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return audioList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['duration'])) {
            $model->duration = $map['duration'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['playUrl'])) {
            $model->playUrl = $map['playUrl'];
        }
        if (isset($map['recordId'])) {
            $model->recordId = $map['recordId'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
