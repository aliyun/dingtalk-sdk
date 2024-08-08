<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetRelatedViewTabDataRequest extends Model
{
    /**
     * @example PROC-62829702-A377-42A9-9CB3-E1C691A0CEDB
     *
     * @var string
     */
    public $formCode;

    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 0
     *
     * @var int
     */
    public $nextToken;

    /**
     * @example OpenDataField_OV2K4SOW2ZGG
     *
     * @var string
     */
    public $relatedField;

    /**
     * @example u_dxcugzT0aPQvcK2PIkzQ00841721291058
     *
     * @var string
     */
    public $relatedInstId;

    /**
     * @example manager6034
     *
     * @var string
     */
    public $viewUserId;
    protected $_name = [
        'formCode'      => 'formCode',
        'maxResults'    => 'maxResults',
        'nextToken'     => 'nextToken',
        'relatedField'  => 'relatedField',
        'relatedInstId' => 'relatedInstId',
        'viewUserId'    => 'viewUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->relatedField) {
            $res['relatedField'] = $this->relatedField;
        }
        if (null !== $this->relatedInstId) {
            $res['relatedInstId'] = $this->relatedInstId;
        }
        if (null !== $this->viewUserId) {
            $res['viewUserId'] = $this->viewUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetRelatedViewTabDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['relatedField'])) {
            $model->relatedField = $map['relatedField'];
        }
        if (isset($map['relatedInstId'])) {
            $model->relatedInstId = $map['relatedInstId'];
        }
        if (isset($map['viewUserId'])) {
            $model->viewUserId = $map['viewUserId'];
        }

        return $model;
    }
}
