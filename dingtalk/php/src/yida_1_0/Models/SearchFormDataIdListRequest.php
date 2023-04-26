<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchFormDataIdListRequest extends Model
{
    /**
     * @example 2018-01-01
     *
     * @var string
     */
    public $createFromTimeGMT;

    /**
     * @example 2018-02-01
     *
     * @var string
     */
    public $createToTimeGMT;

    /**
     * @example zh_CN
     *
     * @var string
     */
    public $language;

    /**
     * @example 2018-01-01
     *
     * @var string
     */
    public $modifiedFromTimeGMT;

    /**
     * @example 2018-02-01
     *
     * @var string
     */
    public $modifiedToTimeGMT;

    /**
     * @example dign1234
     *
     * @var string
     */
    public $originatorId;

    /**
     * @var string
     */
    public $searchFieldJson;

    /**
     * @example hexxx
     *
     * @var string
     */
    public $systemToken;

    /**
     * @example ding1234
     *
     * @var string
     */
    public $userId;

    /**
     * @var int
     */
    public $pageNumber;

    /**
     * @var int
     */
    public $pageSize;
    protected $_name = [
        'createFromTimeGMT'   => 'createFromTimeGMT',
        'createToTimeGMT'     => 'createToTimeGMT',
        'language'            => 'language',
        'modifiedFromTimeGMT' => 'modifiedFromTimeGMT',
        'modifiedToTimeGMT'   => 'modifiedToTimeGMT',
        'originatorId'        => 'originatorId',
        'searchFieldJson'     => 'searchFieldJson',
        'systemToken'         => 'systemToken',
        'userId'              => 'userId',
        'pageNumber'          => 'pageNumber',
        'pageSize'            => 'pageSize',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createFromTimeGMT) {
            $res['createFromTimeGMT'] = $this->createFromTimeGMT;
        }
        if (null !== $this->createToTimeGMT) {
            $res['createToTimeGMT'] = $this->createToTimeGMT;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->modifiedFromTimeGMT) {
            $res['modifiedFromTimeGMT'] = $this->modifiedFromTimeGMT;
        }
        if (null !== $this->modifiedToTimeGMT) {
            $res['modifiedToTimeGMT'] = $this->modifiedToTimeGMT;
        }
        if (null !== $this->originatorId) {
            $res['originatorId'] = $this->originatorId;
        }
        if (null !== $this->searchFieldJson) {
            $res['searchFieldJson'] = $this->searchFieldJson;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchFormDataIdListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createFromTimeGMT'])) {
            $model->createFromTimeGMT = $map['createFromTimeGMT'];
        }
        if (isset($map['createToTimeGMT'])) {
            $model->createToTimeGMT = $map['createToTimeGMT'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['modifiedFromTimeGMT'])) {
            $model->modifiedFromTimeGMT = $map['modifiedFromTimeGMT'];
        }
        if (isset($map['modifiedToTimeGMT'])) {
            $model->modifiedToTimeGMT = $map['modifiedToTimeGMT'];
        }
        if (isset($map['originatorId'])) {
            $model->originatorId = $map['originatorId'];
        }
        if (isset($map['searchFieldJson'])) {
            $model->searchFieldJson = $map['searchFieldJson'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }

        return $model;
    }
}
