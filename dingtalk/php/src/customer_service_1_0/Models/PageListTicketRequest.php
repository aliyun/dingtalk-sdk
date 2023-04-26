<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models;

use AlibabaCloud\Tea\Model;

class PageListTicketRequest extends Model
{
    /**
     * @var int
     */
    public $endTime;

    /**
     * @var string
     */
    public $foreignId;

    /**
     * @example 10
     *
     * @var int
     */
    public $maxResults;

    /**
     * @example 0
     *
     * @var string
     */
    public $nextToken;

    /**
     * @example default
     *
     * @var string
     */
    public $openInstanceId;

    /**
     * @example 1
     *
     * @var int
     */
    public $productionType;

    /**
     * @var string
     */
    public $sourceId;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @example 42
     *
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $ticketId;

    /**
     * @var string
     */
    public $ticketStatus;
    protected $_name = [
        'endTime'        => 'endTime',
        'foreignId'      => 'foreignId',
        'maxResults'     => 'maxResults',
        'nextToken'      => 'nextToken',
        'openInstanceId' => 'openInstanceId',
        'productionType' => 'productionType',
        'sourceId'       => 'sourceId',
        'startTime'      => 'startTime',
        'templateId'     => 'templateId',
        'ticketId'       => 'ticketId',
        'ticketStatus'   => 'ticketStatus',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->foreignId) {
            $res['foreignId'] = $this->foreignId;
        }
        if (null !== $this->maxResults) {
            $res['maxResults'] = $this->maxResults;
        }
        if (null !== $this->nextToken) {
            $res['nextToken'] = $this->nextToken;
        }
        if (null !== $this->openInstanceId) {
            $res['openInstanceId'] = $this->openInstanceId;
        }
        if (null !== $this->productionType) {
            $res['productionType'] = $this->productionType;
        }
        if (null !== $this->sourceId) {
            $res['sourceId'] = $this->sourceId;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->ticketId) {
            $res['ticketId'] = $this->ticketId;
        }
        if (null !== $this->ticketStatus) {
            $res['ticketStatus'] = $this->ticketStatus;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PageListTicketRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['foreignId'])) {
            $model->foreignId = $map['foreignId'];
        }
        if (isset($map['maxResults'])) {
            $model->maxResults = $map['maxResults'];
        }
        if (isset($map['nextToken'])) {
            $model->nextToken = $map['nextToken'];
        }
        if (isset($map['openInstanceId'])) {
            $model->openInstanceId = $map['openInstanceId'];
        }
        if (isset($map['productionType'])) {
            $model->productionType = $map['productionType'];
        }
        if (isset($map['sourceId'])) {
            $model->sourceId = $map['sourceId'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['ticketId'])) {
            $model->ticketId = $map['ticketId'];
        }
        if (isset($map['ticketStatus'])) {
            $model->ticketStatus = $map['ticketStatus'];
        }

        return $model;
    }
}
