<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\GetUserMetricDataResponseBody;

use AlibabaCloud\Tea\Model;

class metricDataList extends Model
{
    /**
     * @example 27
     *
     * @var string
     */
    public $audioPlayLevel;

    /**
     * @example 25
     *
     * @var string
     */
    public $audioRecLevel;

    /**
     * @example 52939
     *
     * @var string
     */
    public $audioRecvBitRate;

    /**
     * @example 59103
     *
     * @var string
     */
    public $audioSendBitRate;

    /**
     * @example 66160
     *
     * @var string
     */
    public $cameraRecvBitRate;

    /**
     * @example 20
     *
     * @var string
     */
    public $cameraRecvFrame;

    /**
     * @example 1920*1080
     *
     * @var string
     */
    public $cameraRecvResolutionActual;

    /**
     * @example 1145172
     *
     * @var string
     */
    public $cameraSendBitRate;

    /**
     * @example 20
     *
     * @var string
     */
    public $cameraSendFrame;

    /**
     * @example 1920*1080
     *
     * @var string
     */
    public $cameraSendResolutionActual;

    /**
     * @example 0
     *
     * @var string
     */
    public $lostRate;

    /**
     * @example 66160
     *
     * @var string
     */
    public $recvBitRate;

    /**
     * @example 20
     *
     * @var string
     */
    public $roundTripTime;

    /**
     * @example 0
     *
     * @var string
     */
    public $screenRecvBitRate;

    /**
     * @example 0
     *
     * @var string
     */
    public $screenRecvFrame;

    /**
     * @example 1920*1080
     *
     * @var string
     */
    public $screenRecvResolutionActual;

    /**
     * @example 15701
     *
     * @var string
     */
    public $screenSendBitRate;

    /**
     * @example 14
     *
     * @var string
     */
    public $screenSendFrame;

    /**
     * @example 1920*1080
     *
     * @var string
     */
    public $screenSendResolutionActual;

    /**
     * @example 1145172
     *
     * @var string
     */
    public $sendBitRate;

    /**
     * @example 1682562120000
     *
     * @var int
     */
    public $timestamp;
    protected $_name = [
        'audioPlayLevel'             => 'audioPlayLevel',
        'audioRecLevel'              => 'audioRecLevel',
        'audioRecvBitRate'           => 'audioRecvBitRate',
        'audioSendBitRate'           => 'audioSendBitRate',
        'cameraRecvBitRate'          => 'cameraRecvBitRate',
        'cameraRecvFrame'            => 'cameraRecvFrame',
        'cameraRecvResolutionActual' => 'cameraRecvResolutionActual',
        'cameraSendBitRate'          => 'cameraSendBitRate',
        'cameraSendFrame'            => 'cameraSendFrame',
        'cameraSendResolutionActual' => 'cameraSendResolutionActual',
        'lostRate'                   => 'lostRate',
        'recvBitRate'                => 'recvBitRate',
        'roundTripTime'              => 'roundTripTime',
        'screenRecvBitRate'          => 'screenRecvBitRate',
        'screenRecvFrame'            => 'screenRecvFrame',
        'screenRecvResolutionActual' => 'screenRecvResolutionActual',
        'screenSendBitRate'          => 'screenSendBitRate',
        'screenSendFrame'            => 'screenSendFrame',
        'screenSendResolutionActual' => 'screenSendResolutionActual',
        'sendBitRate'                => 'sendBitRate',
        'timestamp'                  => 'timestamp',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->audioPlayLevel) {
            $res['audioPlayLevel'] = $this->audioPlayLevel;
        }
        if (null !== $this->audioRecLevel) {
            $res['audioRecLevel'] = $this->audioRecLevel;
        }
        if (null !== $this->audioRecvBitRate) {
            $res['audioRecvBitRate'] = $this->audioRecvBitRate;
        }
        if (null !== $this->audioSendBitRate) {
            $res['audioSendBitRate'] = $this->audioSendBitRate;
        }
        if (null !== $this->cameraRecvBitRate) {
            $res['cameraRecvBitRate'] = $this->cameraRecvBitRate;
        }
        if (null !== $this->cameraRecvFrame) {
            $res['cameraRecvFrame'] = $this->cameraRecvFrame;
        }
        if (null !== $this->cameraRecvResolutionActual) {
            $res['cameraRecvResolutionActual'] = $this->cameraRecvResolutionActual;
        }
        if (null !== $this->cameraSendBitRate) {
            $res['cameraSendBitRate'] = $this->cameraSendBitRate;
        }
        if (null !== $this->cameraSendFrame) {
            $res['cameraSendFrame'] = $this->cameraSendFrame;
        }
        if (null !== $this->cameraSendResolutionActual) {
            $res['cameraSendResolutionActual'] = $this->cameraSendResolutionActual;
        }
        if (null !== $this->lostRate) {
            $res['lostRate'] = $this->lostRate;
        }
        if (null !== $this->recvBitRate) {
            $res['recvBitRate'] = $this->recvBitRate;
        }
        if (null !== $this->roundTripTime) {
            $res['roundTripTime'] = $this->roundTripTime;
        }
        if (null !== $this->screenRecvBitRate) {
            $res['screenRecvBitRate'] = $this->screenRecvBitRate;
        }
        if (null !== $this->screenRecvFrame) {
            $res['screenRecvFrame'] = $this->screenRecvFrame;
        }
        if (null !== $this->screenRecvResolutionActual) {
            $res['screenRecvResolutionActual'] = $this->screenRecvResolutionActual;
        }
        if (null !== $this->screenSendBitRate) {
            $res['screenSendBitRate'] = $this->screenSendBitRate;
        }
        if (null !== $this->screenSendFrame) {
            $res['screenSendFrame'] = $this->screenSendFrame;
        }
        if (null !== $this->screenSendResolutionActual) {
            $res['screenSendResolutionActual'] = $this->screenSendResolutionActual;
        }
        if (null !== $this->sendBitRate) {
            $res['sendBitRate'] = $this->sendBitRate;
        }
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return metricDataList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['audioPlayLevel'])) {
            $model->audioPlayLevel = $map['audioPlayLevel'];
        }
        if (isset($map['audioRecLevel'])) {
            $model->audioRecLevel = $map['audioRecLevel'];
        }
        if (isset($map['audioRecvBitRate'])) {
            $model->audioRecvBitRate = $map['audioRecvBitRate'];
        }
        if (isset($map['audioSendBitRate'])) {
            $model->audioSendBitRate = $map['audioSendBitRate'];
        }
        if (isset($map['cameraRecvBitRate'])) {
            $model->cameraRecvBitRate = $map['cameraRecvBitRate'];
        }
        if (isset($map['cameraRecvFrame'])) {
            $model->cameraRecvFrame = $map['cameraRecvFrame'];
        }
        if (isset($map['cameraRecvResolutionActual'])) {
            $model->cameraRecvResolutionActual = $map['cameraRecvResolutionActual'];
        }
        if (isset($map['cameraSendBitRate'])) {
            $model->cameraSendBitRate = $map['cameraSendBitRate'];
        }
        if (isset($map['cameraSendFrame'])) {
            $model->cameraSendFrame = $map['cameraSendFrame'];
        }
        if (isset($map['cameraSendResolutionActual'])) {
            $model->cameraSendResolutionActual = $map['cameraSendResolutionActual'];
        }
        if (isset($map['lostRate'])) {
            $model->lostRate = $map['lostRate'];
        }
        if (isset($map['recvBitRate'])) {
            $model->recvBitRate = $map['recvBitRate'];
        }
        if (isset($map['roundTripTime'])) {
            $model->roundTripTime = $map['roundTripTime'];
        }
        if (isset($map['screenRecvBitRate'])) {
            $model->screenRecvBitRate = $map['screenRecvBitRate'];
        }
        if (isset($map['screenRecvFrame'])) {
            $model->screenRecvFrame = $map['screenRecvFrame'];
        }
        if (isset($map['screenRecvResolutionActual'])) {
            $model->screenRecvResolutionActual = $map['screenRecvResolutionActual'];
        }
        if (isset($map['screenSendBitRate'])) {
            $model->screenSendBitRate = $map['screenSendBitRate'];
        }
        if (isset($map['screenSendFrame'])) {
            $model->screenSendFrame = $map['screenSendFrame'];
        }
        if (isset($map['screenSendResolutionActual'])) {
            $model->screenSendResolutionActual = $map['screenSendResolutionActual'];
        }
        if (isset($map['sendBitRate'])) {
            $model->sendBitRate = $map['sendBitRate'];
        }
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }

        return $model;
    }
}
