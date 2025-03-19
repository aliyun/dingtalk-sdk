<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class StartStreamOutRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example grip
     *
     * @var string
     */
    public $mode;

    /**
     * @description This parameter is required.
     *
     * @example true
     *
     * @var bool
     */
    public $needHostJoin;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $smallWindowPosition;

    /**
     * @description This parameter is required.
     *
     * @example 推流名称
     *
     * @var string
     */
    public $streamName;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $streamUrlList;

    /**
     * @description This parameter is required.
     *
     * @example 27SaQ3iiHLN0uwqcPisedfreNwiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'mode' => 'mode',
        'needHostJoin' => 'needHostJoin',
        'smallWindowPosition' => 'smallWindowPosition',
        'streamName' => 'streamName',
        'streamUrlList' => 'streamUrlList',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->mode) {
            $res['mode'] = $this->mode;
        }
        if (null !== $this->needHostJoin) {
            $res['needHostJoin'] = $this->needHostJoin;
        }
        if (null !== $this->smallWindowPosition) {
            $res['smallWindowPosition'] = $this->smallWindowPosition;
        }
        if (null !== $this->streamName) {
            $res['streamName'] = $this->streamName;
        }
        if (null !== $this->streamUrlList) {
            $res['streamUrlList'] = $this->streamUrlList;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return StartStreamOutRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mode'])) {
            $model->mode = $map['mode'];
        }
        if (isset($map['needHostJoin'])) {
            $model->needHostJoin = $map['needHostJoin'];
        }
        if (isset($map['smallWindowPosition'])) {
            $model->smallWindowPosition = $map['smallWindowPosition'];
        }
        if (isset($map['streamName'])) {
            $model->streamName = $map['streamName'];
        }
        if (isset($map['streamUrlList'])) {
            if (!empty($map['streamUrlList'])) {
                $model->streamUrlList = $map['streamUrlList'];
            }
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
