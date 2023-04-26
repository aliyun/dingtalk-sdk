<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class PageFormBaseInfosRequest extends Model
{
    /**
     * @example APP_PBKT0MFBEBTDO8T7SLVP
     *
     * @var string
     */
    public $appKey;

    /**
     * @var string[]
     */
    public $formTypeList;

    /**
     * @var string
     */
    public $language;

    /**
     * @var int
     */
    public $pageIndex;

    /**
     * @var int
     */
    public $pageSize;

    /**
     * @example hexxx
     *
     * @var string
     */
    public $systemToken;

    /**
     * @example david123
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appKey'       => 'appKey',
        'formTypeList' => 'formTypeList',
        'language'     => 'language',
        'pageIndex'    => 'pageIndex',
        'pageSize'     => 'pageSize',
        'systemToken'  => 'systemToken',
        'userId'       => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appKey) {
            $res['appKey'] = $this->appKey;
        }
        if (null !== $this->formTypeList) {
            $res['formTypeList'] = $this->formTypeList;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->pageIndex) {
            $res['pageIndex'] = $this->pageIndex;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
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
     * @return PageFormBaseInfosRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appKey'])) {
            $model->appKey = $map['appKey'];
        }
        if (isset($map['formTypeList'])) {
            if (!empty($map['formTypeList'])) {
                $model->formTypeList = $map['formTypeList'];
            }
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['pageIndex'])) {
            $model->pageIndex = $map['pageIndex'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
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
