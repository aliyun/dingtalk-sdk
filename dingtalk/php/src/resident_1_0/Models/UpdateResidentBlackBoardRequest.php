<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateResidentBlackBoardRequest extends Model
{
    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var string
     */
    public $title;

    /**
     * @var string
     */
    public $context;

    /**
     * @var string
     */
    public $mediaId;

    /**
     * @var string
     */
    public $blackboardId;
    protected $_name = [
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingCorpId'         => 'dingCorpId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'title'              => 'title',
        'context'            => 'context',
        'mediaId'            => 'mediaId',
        'blackboardId'       => 'blackboardId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->context) {
            $res['context'] = $this->context;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->blackboardId) {
            $res['blackboardId'] = $this->blackboardId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateResidentBlackBoardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['context'])) {
            $model->context = $map['context'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['blackboardId'])) {
            $model->blackboardId = $map['blackboardId'];
        }

        return $model;
    }
}
