<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListApplicationRequest extends Model
{
    /**
     * @example createdByMe
     *
     * @var string
     */
    public $appFilter;

    /**
     * @example 步凡的测试应用
     *
     * @var string
     */
    public $appNameSearchKeyword;

    /**
     * @description This parameter is required.
     *
     * @example ding5d17e3add038d44535c2f4657eb6378e
     *
     * @var string
     */
    public $corpId;

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
     * @description This parameter is required.
     *
     * @example B073AF673BEB044D59F8F612D65E1EA2
     *
     * @var string
     */
    public $token;

    /**
     * @description This parameter is required.
     *
     * @example ding173982232112232
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appFilter'            => 'appFilter',
        'appNameSearchKeyword' => 'appNameSearchKeyword',
        'corpId'               => 'corpId',
        'pageNumber'           => 'pageNumber',
        'pageSize'             => 'pageSize',
        'token'                => 'token',
        'userId'               => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appFilter) {
            $res['appFilter'] = $this->appFilter;
        }
        if (null !== $this->appNameSearchKeyword) {
            $res['appNameSearchKeyword'] = $this->appNameSearchKeyword;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->token) {
            $res['token'] = $this->token;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListApplicationRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appFilter'])) {
            $model->appFilter = $map['appFilter'];
        }
        if (isset($map['appNameSearchKeyword'])) {
            $model->appNameSearchKeyword = $map['appNameSearchKeyword'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['token'])) {
            $model->token = $map['token'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
