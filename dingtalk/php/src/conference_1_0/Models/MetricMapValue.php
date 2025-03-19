<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class MetricMapValue extends Model
{
    /**
     * @example 1682562120000
     *
     * @var int
     */
    public $timestamp;

    /**
     * @example 1145172
     *
     * @var string
     */
    public $sendBitRate;

    /**
     * @example 111
     *
     * @var string
     */
    public $recvBitRate;

    /**
     * @example 0
     *
     * @var string
     */
    public $lostRate;

    /**
     * @example 20
     *
     * @var string
     */
    public $roundTripTime;

    /**
     * @example 59103
     *
     * @var string
     */
    public $audioSendBitRate;

    /**
     * @example 52939
     *
     * @var string
     */
    public $audioRecvBitRate;

    /**
     * @example 25
     *
     * @var string
     */
    public $audioRecLevel;

    /**
     * @example 27
     *
     * @var string
     */
    public $audioPlayLevel;

    /**
     * @example 1145172
     *
     * @var string
     */
    public $cameraSendBitRate;

    /**
     * @example 66160
     *
     * @var string
     */
    public $cameraRecvBitRate;

    /**
     * @example 1920*1080
     *
     * @var string
     */
    public $cameraSendResolutionActual;

    /**
     * @example 1920*1080
     *
     * @var string
     */
    public $cameraRecvResolutionActual;

    /**
     * @example 20
     *
     * @var string
     */
    public $cameraSendFrame;

    /**
     * @example 15701
     *
     * @var string
     */
    public $screenSendBitRate;

    /**
     * @example 20
     *
     * @var string
     */
    public $cameraRecvFrame;

    /**
     * @example 0
     *
     * @var string
     */
    public $screenRecvBitRate;

    /**
     * @example 1920*1080
     *
     * @var string
     */
    public $screenSendResolutionActual;

    /**
     * @example 1920*1080
     *
     * @var string
     */
    public $screenRecvResolutionActual;

    /**
     * @example 14
     *
     * @var string
     */
    public $screenSendFrame;

    /**
     * @example 0
     *
     * @var string
     */
    public $screenRecvFrame;

    /**
     * @example 0
     *
     * @var string
     */
    public $audioJitterMax;

    /**
     * @example 0
     *
     * @var string
     */
    public $audioJitterAvg;
    protected $_name = [
        'timestamp' => 'timestamp',
        'sendBitRate' => 'sendBitRate',
        'recvBitRate' => 'recvBitRate',
        'lostRate' => 'lostRate',
        'roundTripTime' => 'roundTripTime',
        'audioSendBitRate' => 'audioSendBitRate',
        'audioRecvBitRate' => 'audioRecvBitRate',
        'audioRecLevel' => 'audioRecLevel',
        'audioPlayLevel' => 'audioPlayLevel',
        'cameraSendBitRate' => 'cameraSendBitRate',
        'cameraRecvBitRate' => 'cameraRecvBitRate',
        'cameraSendResolutionActual' => 'cameraSendResolutionActual',
        'cameraRecvResolutionActual' => 'cameraRecvResolutionActual',
        'cameraSendFrame' => 'cameraSendFrame',
        'screenSendBitRate' => 'screenSendBitRate',
        'cameraRecvFrame' => 'cameraRecvFrame',
        'screenRecvBitRate' => 'screenRecvBitRate',
        'screenSendResolutionActual' => 'screenSendResolutionActual',
        'screenRecvResolutionActual' => 'screenRecvResolutionActual',
        'screenSendFrame' => 'screenSendFrame',
        'screenRecvFrame' => 'screenRecvFrame',
        'audioJitterMax' => 'audioJitterMax',
        'audioJitterAvg' => 'audioJitterAvg',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
        }
        if (null !== $this->sendBitRate) {
            $res['sendBitRate'] = $this->sendBitRate;
        }
        if (null !== $this->recvBitRate) {
            $res['recvBitRate'] = $this->recvBitRate;
        }
        if (null !== $this->lostRate) {
            $res['lostRate'] = $this->lostRate;
        }
        if (null !== $this->roundTripTime) {
            $res['roundTripTime'] = $this->roundTripTime;
        }
        if (null !== $this->audioSendBitRate) {
            $res['audioSendBitRate'] = $this->audioSendBitRate;
        }
        if (null !== $this->audioRecvBitRate) {
            $res['audioRecvBitRate'] = $this->audioRecvBitRate;
        }
        if (null !== $this->audioRecLevel) {
            $res['audioRecLevel'] = $this->audioRecLevel;
        }
        if (null !== $this->audioPlayLevel) {
            $res['audioPlayLevel'] = $this->audioPlayLevel;
        }
        if (null !== $this->cameraSendBitRate) {
            $res['cameraSendBitRate'] = $this->cameraSendBitRate;
        }
        if (null !== $this->cameraRecvBitRate) {
            $res['cameraRecvBitRate'] = $this->cameraRecvBitRate;
        }
        if (null !== $this->cameraSendResolutionActual) {
            $res['cameraSendResolutionActual'] = $this->cameraSendResolutionActual;
        }
        if (null !== $this->cameraRecvResolutionActual) {
            $res['cameraRecvResolutionActual'] = $this->cameraRecvResolutionActual;
        }
        if (null !== $this->cameraSendFrame) {
            $res['cameraSendFrame'] = $this->cameraSendFrame;
        }
        if (null !== $this->screenSendBitRate) {
            $res['screenSendBitRate'] = $this->screenSendBitRate;
        }
        if (null !== $this->cameraRecvFrame) {
            $res['cameraRecvFrame'] = $this->cameraRecvFrame;
        }
        if (null !== $this->screenRecvBitRate) {
            $res['screenRecvBitRate'] = $this->screenRecvBitRate;
        }
        if (null !== $this->screenSendResolutionActual) {
            $res['screenSendResolutionActual'] = $this->screenSendResolutionActual;
        }
        if (null !== $this->screenRecvResolutionActual) {
            $res['screenRecvResolutionActual'] = $this->screenRecvResolutionActual;
        }
        if (null !== $this->screenSendFrame) {
            $res['screenSendFrame'] = $this->screenSendFrame;
        }
        if (null !== $this->screenRecvFrame) {
            $res['screenRecvFrame'] = $this->screenRecvFrame;
        }
        if (null !== $this->audioJitterMax) {
            $res['audioJitterMax'] = $this->audioJitterMax;
        }
        if (null !== $this->audioJitterAvg) {
            $res['audioJitterAvg'] = $this->audioJitterAvg;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MetricMapValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }
        if (isset($map['sendBitRate'])) {
            $model->sendBitRate = $map['sendBitRate'];
        }
        if (isset($map['recvBitRate'])) {
            $model->recvBitRate = $map['recvBitRate'];
        }
        if (isset($map['lostRate'])) {
            $model->lostRate = $map['lostRate'];
        }
        if (isset($map['roundTripTime'])) {
            $model->roundTripTime = $map['roundTripTime'];
        }
        if (isset($map['audioSendBitRate'])) {
            $model->audioSendBitRate = $map['audioSendBitRate'];
        }
        if (isset($map['audioRecvBitRate'])) {
            $model->audioRecvBitRate = $map['audioRecvBitRate'];
        }
        if (isset($map['audioRecLevel'])) {
            $model->audioRecLevel = $map['audioRecLevel'];
        }
        if (isset($map['audioPlayLevel'])) {
            $model->audioPlayLevel = $map['audioPlayLevel'];
        }
        if (isset($map['cameraSendBitRate'])) {
            $model->cameraSendBitRate = $map['cameraSendBitRate'];
        }
        if (isset($map['cameraRecvBitRate'])) {
            $model->cameraRecvBitRate = $map['cameraRecvBitRate'];
        }
        if (isset($map['cameraSendResolutionActual'])) {
            $model->cameraSendResolutionActual = $map['cameraSendResolutionActual'];
        }
        if (isset($map['cameraRecvResolutionActual'])) {
            $model->cameraRecvResolutionActual = $map['cameraRecvResolutionActual'];
        }
        if (isset($map['cameraSendFrame'])) {
            $model->cameraSendFrame = $map['cameraSendFrame'];
        }
        if (isset($map['screenSendBitRate'])) {
            $model->screenSendBitRate = $map['screenSendBitRate'];
        }
        if (isset($map['cameraRecvFrame'])) {
            $model->cameraRecvFrame = $map['cameraRecvFrame'];
        }
        if (isset($map['screenRecvBitRate'])) {
            $model->screenRecvBitRate = $map['screenRecvBitRate'];
        }
        if (isset($map['screenSendResolutionActual'])) {
            $model->screenSendResolutionActual = $map['screenSendResolutionActual'];
        }
        if (isset($map['screenRecvResolutionActual'])) {
            $model->screenRecvResolutionActual = $map['screenRecvResolutionActual'];
        }
        if (isset($map['screenSendFrame'])) {
            $model->screenSendFrame = $map['screenSendFrame'];
        }
        if (isset($map['screenRecvFrame'])) {
            $model->screenRecvFrame = $map['screenRecvFrame'];
        }
        if (isset($map['audioJitterMax'])) {
            $model->audioJitterMax = $map['audioJitterMax'];
        }
        if (isset($map['audioJitterAvg'])) {
            $model->audioJitterAvg = $map['audioJitterAvg'];
        }

        return $model;
    }
}
