<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchSaveFormDataRequest extends Model
{
    /**
     * @example APP_XCE0EVXS6DYG3YDYC5RD
     *
     * @var string
     */
    public $appType;

    /**
     * @example true
     *
     * @var bool
     */
    public $asynchronousExecution;

    /**
     * @example "{\"countrySelectField_l0c1cwiu\":[{\"value\":\"US\"}],\"addressField_l0c1cwiy\":{\"address\":\"111\",\"regionIds\":[460000,469027,469023401],\"regionText\":[{\"en_US\":\"hai+nan+sheng\",\"zh_CN\":\"海南省\"},{\"en_US\":\"cheng+mai+xian\",\"zh_CN\":\"澄迈县\"},{\"en_US\":\"guo+ying+hong+gang+nong+chang\",\"zh_CN\":\"国营红岗农场\"}]}}"
     *
     * @var string[]
     */
    public $formDataJsonList;

    /**
     * @example FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
     *
     * @var string
     */
    public $formUuid;

    /**
     * @example true
     *
     * @var bool
     */
    public $keepRunningAfterException;

    /**
     * @example true
     *
     * @var bool
     */
    public $noExecuteExpression;

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
        'appType'                   => 'appType',
        'asynchronousExecution'     => 'asynchronousExecution',
        'formDataJsonList'          => 'formDataJsonList',
        'formUuid'                  => 'formUuid',
        'keepRunningAfterException' => 'keepRunningAfterException',
        'noExecuteExpression'       => 'noExecuteExpression',
        'systemToken'               => 'systemToken',
        'userId'                    => 'userId',
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
        if (null !== $this->asynchronousExecution) {
            $res['asynchronousExecution'] = $this->asynchronousExecution;
        }
        if (null !== $this->formDataJsonList) {
            $res['formDataJsonList'] = $this->formDataJsonList;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->keepRunningAfterException) {
            $res['keepRunningAfterException'] = $this->keepRunningAfterException;
        }
        if (null !== $this->noExecuteExpression) {
            $res['noExecuteExpression'] = $this->noExecuteExpression;
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
     * @return BatchSaveFormDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['asynchronousExecution'])) {
            $model->asynchronousExecution = $map['asynchronousExecution'];
        }
        if (isset($map['formDataJsonList'])) {
            if (!empty($map['formDataJsonList'])) {
                $model->formDataJsonList = $map['formDataJsonList'];
            }
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['keepRunningAfterException'])) {
            $model->keepRunningAfterException = $map['keepRunningAfterException'];
        }
        if (isset($map['noExecuteExpression'])) {
            $model->noExecuteExpression = $map['noExecuteExpression'];
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
