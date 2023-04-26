<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\BatchCreateRequest\data;
use AlibabaCloud\Tea\Model;

class BatchCreateRequest extends Model
{
    /**
     * @example industry_center
     *
     * @var string
     */
    public $cardBizCode;

    /**
     * @var data
     */
    public $data;

    /**
     * @example AFC35F13-8A88-728F-27C5-3616AD7DFF2E
     *
     * @var string
     */
    public $identifier;

    /**
     * @example 4
     *
     * @var int
     */
    public $jsVersion;

    /**
     * @example QUPEIYIN
     *
     * @var string
     */
    public $sourceType;

    /**
     * @var string
     */
    public $userid;
    protected $_name = [
        'cardBizCode' => 'cardBizCode',
        'data'        => 'data',
        'identifier'  => 'identifier',
        'jsVersion'   => 'jsVersion',
        'sourceType'  => 'sourceType',
        'userid'      => 'userid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardBizCode) {
            $res['cardBizCode'] = $this->cardBizCode;
        }
        if (null !== $this->data) {
            $res['data'] = null !== $this->data ? $this->data->toMap() : null;
        }
        if (null !== $this->identifier) {
            $res['identifier'] = $this->identifier;
        }
        if (null !== $this->jsVersion) {
            $res['jsVersion'] = $this->jsVersion;
        }
        if (null !== $this->sourceType) {
            $res['sourceType'] = $this->sourceType;
        }
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchCreateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardBizCode'])) {
            $model->cardBizCode = $map['cardBizCode'];
        }
        if (isset($map['data'])) {
            $model->data = data::fromMap($map['data']);
        }
        if (isset($map['identifier'])) {
            $model->identifier = $map['identifier'];
        }
        if (isset($map['jsVersion'])) {
            $model->jsVersion = $map['jsVersion'];
        }
        if (isset($map['sourceType'])) {
            $model->sourceType = $map['sourceType'];
        }
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }

        return $model;
    }
}
