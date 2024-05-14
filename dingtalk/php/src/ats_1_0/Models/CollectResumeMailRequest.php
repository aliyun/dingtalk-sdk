<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectResumeMailRequest\resumeFile;
use AlibabaCloud\Tea\Model;

class CollectResumeMailRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example ddats
     *
     * @var string
     */
    public $bizCode;

    /**
     * @description This parameter is required.
     *
     * @example liepin
     *
     * @var string
     */
    public $channelCode;

    /**
     * @example jobId8fc0d56a605d495ea0214af7axxxxxxx
     *
     * @var string
     */
    public $deliverJobId;

    /**
     * @description This parameter is required.
     *
     * @example xxxx@163.com
     *
     * @var string
     */
    public $fromMailAddress;

    /**
     * @var bool
     */
    public $historyMailImport;

    /**
     * @description This parameter is required.
     *
     * @example xxxxxxxx
     *
     * @var string
     */
    public $mailId;

    /**
     * @description This parameter is required.
     *
     * @example xxxxx应聘贵公司xxx职位
     *
     * @var string
     */
    public $mailTitle;

    /**
     * @example 2701606624233xxxxx
     *
     * @var string
     */
    public $optUserId;

    /**
     * @description This parameter is required.
     *
     * @example xxxx@163.com
     *
     * @var string
     */
    public $receiveMailAddress;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $receiveMailType;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $receivedTime;

    /**
     * @example http:www.xxx.com
     *
     * @var string
     */
    public $resumeChannelUrl;

    /**
     * @description This parameter is required.
     *
     * @var resumeFile
     */
    public $resumeFile;
    protected $_name = [
        'bizCode'            => 'bizCode',
        'channelCode'        => 'channelCode',
        'deliverJobId'       => 'deliverJobId',
        'fromMailAddress'    => 'fromMailAddress',
        'historyMailImport'  => 'historyMailImport',
        'mailId'             => 'mailId',
        'mailTitle'          => 'mailTitle',
        'optUserId'          => 'optUserId',
        'receiveMailAddress' => 'receiveMailAddress',
        'receiveMailType'    => 'receiveMailType',
        'receivedTime'       => 'receivedTime',
        'resumeChannelUrl'   => 'resumeChannelUrl',
        'resumeFile'         => 'resumeFile',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->channelCode) {
            $res['channelCode'] = $this->channelCode;
        }
        if (null !== $this->deliverJobId) {
            $res['deliverJobId'] = $this->deliverJobId;
        }
        if (null !== $this->fromMailAddress) {
            $res['fromMailAddress'] = $this->fromMailAddress;
        }
        if (null !== $this->historyMailImport) {
            $res['historyMailImport'] = $this->historyMailImport;
        }
        if (null !== $this->mailId) {
            $res['mailId'] = $this->mailId;
        }
        if (null !== $this->mailTitle) {
            $res['mailTitle'] = $this->mailTitle;
        }
        if (null !== $this->optUserId) {
            $res['optUserId'] = $this->optUserId;
        }
        if (null !== $this->receiveMailAddress) {
            $res['receiveMailAddress'] = $this->receiveMailAddress;
        }
        if (null !== $this->receiveMailType) {
            $res['receiveMailType'] = $this->receiveMailType;
        }
        if (null !== $this->receivedTime) {
            $res['receivedTime'] = $this->receivedTime;
        }
        if (null !== $this->resumeChannelUrl) {
            $res['resumeChannelUrl'] = $this->resumeChannelUrl;
        }
        if (null !== $this->resumeFile) {
            $res['resumeFile'] = null !== $this->resumeFile ? $this->resumeFile->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollectResumeMailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['channelCode'])) {
            $model->channelCode = $map['channelCode'];
        }
        if (isset($map['deliverJobId'])) {
            $model->deliverJobId = $map['deliverJobId'];
        }
        if (isset($map['fromMailAddress'])) {
            $model->fromMailAddress = $map['fromMailAddress'];
        }
        if (isset($map['historyMailImport'])) {
            $model->historyMailImport = $map['historyMailImport'];
        }
        if (isset($map['mailId'])) {
            $model->mailId = $map['mailId'];
        }
        if (isset($map['mailTitle'])) {
            $model->mailTitle = $map['mailTitle'];
        }
        if (isset($map['optUserId'])) {
            $model->optUserId = $map['optUserId'];
        }
        if (isset($map['receiveMailAddress'])) {
            $model->receiveMailAddress = $map['receiveMailAddress'];
        }
        if (isset($map['receiveMailType'])) {
            $model->receiveMailType = $map['receiveMailType'];
        }
        if (isset($map['receivedTime'])) {
            $model->receivedTime = $map['receivedTime'];
        }
        if (isset($map['resumeChannelUrl'])) {
            $model->resumeChannelUrl = $map['resumeChannelUrl'];
        }
        if (isset($map['resumeFile'])) {
            $model->resumeFile = resumeFile::fromMap($map['resumeFile']);
        }

        return $model;
    }
}
