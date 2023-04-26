<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryServiceRecordRequest extends Model
{
    /**
     * @example APP_XCE0EVXS6DYG3YDYC5RD
     *
     * @var string
     */
    public $appType;

    /**
     * @example FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
     *
     * @var string
     */
    public $formUuid;

    /**
     * @example HTTP
     *
     * @var string
     */
    public $hookType;

    /**
     * @example INVOKE-E7766VC1KJ4ZVFCR346USCT2ORYI2UVRBHA1L0
     *
     * @var string
     */
    public $hookUuid;

    /**
     * @example FINST-NJS33HHSLFNH533HHOFN
     *
     * @var string
     */
    public $instanceId;

    /**
     * @example 2022-03-28
     *
     * @var string
     */
    public $invokeAfterDateGMT;

    /**
     * @example 2022-03-29
     *
     * @var string
     */
    public $invokeBeforeDateGMT;

    /**
     * @example 可选值：SUCCESS、FAIL、FINAL_SUCCESS、ERROR
     *
     * @var string
     */
    public $invokeStatus;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 100
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example www.aliwork.com/query/
     *
     * @var string
     */
    public $requestUrl;

    /**
     * @example INVOKE-E7766VC1KJ4ZVFCR346USCT2ORYI2UVRBHA1LI
     *
     * @var string
     */
    public $sourceUuid;

    /**
     * @example true
     *
     * @var bool
     */
    public $success;

    /**
     * @example 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
     *
     * @var string
     */
    public $systemToken;

    /**
     * @example ding173982232112232
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'             => 'appType',
        'formUuid'            => 'formUuid',
        'hookType'            => 'hookType',
        'hookUuid'            => 'hookUuid',
        'instanceId'          => 'instanceId',
        'invokeAfterDateGMT'  => 'invokeAfterDateGMT',
        'invokeBeforeDateGMT' => 'invokeBeforeDateGMT',
        'invokeStatus'        => 'invokeStatus',
        'pageNumber'          => 'pageNumber',
        'pageSize'            => 'pageSize',
        'requestUrl'          => 'requestUrl',
        'sourceUuid'          => 'sourceUuid',
        'success'             => 'success',
        'systemToken'         => 'systemToken',
        'userId'              => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->hookType) {
            $res['hookType'] = $this->hookType;
        }
        if (null !== $this->hookUuid) {
            $res['hookUuid'] = $this->hookUuid;
        }
        if (null !== $this->instanceId) {
            $res['instanceId'] = $this->instanceId;
        }
        if (null !== $this->invokeAfterDateGMT) {
            $res['invokeAfterDateGMT'] = $this->invokeAfterDateGMT;
        }
        if (null !== $this->invokeBeforeDateGMT) {
            $res['invokeBeforeDateGMT'] = $this->invokeBeforeDateGMT;
        }
        if (null !== $this->invokeStatus) {
            $res['invokeStatus'] = $this->invokeStatus;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->requestUrl) {
            $res['requestUrl'] = $this->requestUrl;
        }
        if (null !== $this->sourceUuid) {
            $res['sourceUuid'] = $this->sourceUuid;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryServiceRecordRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['hookType'])) {
            $model->hookType = $map['hookType'];
        }
        if (isset($map['hookUuid'])) {
            $model->hookUuid = $map['hookUuid'];
        }
        if (isset($map['instanceId'])) {
            $model->instanceId = $map['instanceId'];
        }
        if (isset($map['invokeAfterDateGMT'])) {
            $model->invokeAfterDateGMT = $map['invokeAfterDateGMT'];
        }
        if (isset($map['invokeBeforeDateGMT'])) {
            $model->invokeBeforeDateGMT = $map['invokeBeforeDateGMT'];
        }
        if (isset($map['invokeStatus'])) {
            $model->invokeStatus = $map['invokeStatus'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['requestUrl'])) {
            $model->requestUrl = $map['requestUrl'];
        }
        if (isset($map['sourceUuid'])) {
            $model->sourceUuid = $map['sourceUuid'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
